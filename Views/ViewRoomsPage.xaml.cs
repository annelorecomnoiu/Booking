using booking.Database;
using booking.Database.Models;
using booking.Database.Repository;
using booking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace booking.Views
{
    /// <summary>
    /// Interaction logic for ViewRoomsPage.xaml
    /// </summary>
    public partial class ViewRoomsPage : Window
    {
        public ViewRoomsPage()
        {
            InitializeComponent();
            CreateTable();
        }
        public void CreateTable()
        {
            int numberOfColumns = 4;
            for (int x = 0; x < numberOfColumns; x++)
            {
                TableRooms.Columns.Add(new TableColumn());
            }
            TableRooms.RowGroups.Add(new TableRowGroup());
            TableRooms.RowGroups[0].Rows.Add(new TableRow());
            TableRow currentRow = TableRooms.RowGroups[0].Rows[0];

            //Table Title
            currentRow.FontSize = 30;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Camere \n"))));


            //Header Row
            TableRooms.RowGroups[0].Rows.Add(new TableRow());
            currentRow = TableRooms.RowGroups[0].Rows[1];
            currentRow.FontSize = 18;

            Paragraph tableHeader = new Paragraph(new Run("Tipuri camere"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Capacitate"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Numar camere"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Pret"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Dotari \n"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Imagini \n"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));


            using (var dbContext = new BookingContext())
            {
                CameraRepository cameraRepository = new CameraRepository(dbContext);
                List<Camera> camere = cameraRepository.GetCamere();

                PretRepository pretRepository = new PretRepository(dbContext);
                List<Pret> preturi = pretRepository.GetPreturi();

                DotareRepository dotareRepository = new DotareRepository(dbContext);
                List<Dotare> dotari = dotareRepository.GetDotari();

                DotareCameraRepository dotareCameraRepository = new DotareCameraRepository(dbContext);
                List<DotareCamera> dotariCamere = dotareCameraRepository.GetDotareCamera();

                ImagineRepository imagineRepository = new ImagineRepository(dbContext);
                List<Imagine> imagini = imagineRepository.GetImagine();

                int currentServiceNo = 2;
                RemoveRoomViewModel removeRoomViewModel = new RemoveRoomViewModel(); 
                foreach (var camera in camere)
                    if(removeRoomViewModel.Camere.Contains(camera.Nume))
                    {
                        TableRooms.RowGroups[0].Rows.Add(new TableRow());
                        currentRow = TableRooms.RowGroups[0].Rows[currentServiceNo];
                        currentRow.FontSize = 14;

                        Paragraph tableServiceEntry = new Paragraph(new Run(camera.Nume));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));

                        tableServiceEntry = new Paragraph(new Run(camera.Capacitate.ToString()));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));

                        tableServiceEntry = new Paragraph(new Run(camera.NrCamere.ToString()));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));


                        String preturiCamera = "";
                        foreach (var pret in preturi)
                        {
                            if (pret.IdCamera == camera.Id)
                                preturiCamera = preturiCamera + pret.Valoare + " " + pret.DataStart + " " + pret.DataEnd + "\n ";
                        }

                        tableServiceEntry = new Paragraph(new Run(preturiCamera));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));


                        String dotariCamera = "";
                        foreach (var dotare in dotari)
                        {
                            foreach (var dotareCamera in dotariCamere)
                            {
                                if (dotare.Id == dotareCamera.IdDotare && camera.Id == dotareCamera.IdCamera)
                                    dotariCamera = dotariCamera + dotare.Nume + "\n ";
                            }
                        }
                        tableServiceEntry = new Paragraph(new Run(dotariCamera));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));

                        string imagePath1 = "";
                        string imagePath2 = "";
                        string imagePath3 = "";
                        foreach (var img in imagini)
                            if (img.IdCamera == camera.Id)
                            {
                                if (imagePath1 == "")
                                    imagePath1 = imagePath1 + img.Path;
                                else
                                {
                                    if (imagePath2 == "")
                                        imagePath2 = imagePath2 + img.Path;
                                    else
                                        imagePath3 = imagePath3 + img.Path;
                                } 
                                    
                            }

                        BitmapImage bi1 = new BitmapImage(new Uri(imagePath1));
                        Image image1 = new Image();
                        image1.Source = bi1;
                        InlineUIContainer container1 = new InlineUIContainer(image1);
                        tableServiceEntry = new Paragraph(container1);
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));

                        if (imagePath2 != "")
                        {
                            BitmapImage bi2 = new BitmapImage(new Uri(imagePath2));
                            Image image2 = new Image();
                            image2.Source = bi2;
                            InlineUIContainer container2 = new InlineUIContainer(image2);
                            tableServiceEntry = new Paragraph(container2);
                            currentRow.Cells.Add(new TableCell(tableServiceEntry));
                        }

                        if (imagePath3 != "")
                        {
                            BitmapImage bi3 = new BitmapImage(new Uri(imagePath3));
                            Image image3 = new Image();
                            image3.Source = bi3;
                            InlineUIContainer container3 = new InlineUIContainer(image3);
                            tableServiceEntry = new Paragraph(container3);
                            currentRow.Cells.Add(new TableCell(tableServiceEntry));
                        }
                        currentServiceNo++;
                    }
            }
        }
    }
}