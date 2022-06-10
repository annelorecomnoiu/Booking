using booking.Database;
using booking.Database.Models;
using booking.Database.Repository;
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
    /// Interaction logic for ViewRezervationsPage.xaml
    /// </summary>
    public partial class ViewAllRezervationsPage : Window
    {
        public ViewAllRezervationsPage()
        {
            InitializeComponent();
            CreateTable();
        }

        public void CreateTable()
        {
            int numberOfColumns = 5;
            for (int x = 0; x < numberOfColumns; x++)
            {
                TableOffers.Columns.Add(new TableColumn());
            }
            TableOffers.RowGroups.Add(new TableRowGroup());
            TableOffers.RowGroups[0].Rows.Add(new TableRow());
            TableRow currentRow = TableOffers.RowGroups[0].Rows[0];

            //Table Title
            currentRow.FontSize = 24;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Istoric rezervari \n"))));
            currentRow.Cells[0].ColumnSpan = 5;

            //Header Row
            TableOffers.RowGroups[0].Rows.Add(new TableRow());
            currentRow = TableOffers.RowGroups[0].Rows[1];
            currentRow.FontSize = 18;

            Paragraph tableHeader = new Paragraph(new Run("Utilizator"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Tip camera"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Nr camere"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Oferta"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Data inceput"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Data sfarsit \n"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));


            using (var dbContext = new BookingContext())
            {
                RezervareRepository rezervareRepository = new RezervareRepository(dbContext);
                List<Rezervare> rezervari = rezervareRepository.GetRezervari();

                CameraRepository cameraRepository = new CameraRepository(dbContext);
                List<Camera> camere = cameraRepository.GetCamere();

                OfertaRepository ofertaRepository = new OfertaRepository(dbContext);
                List<Oferta> oferte = ofertaRepository.GetOferte();

                int currentOfferNo = 2;

                foreach (var rezervare in rezervari)
                {
                    TableOffers.RowGroups[0].Rows.Add(new TableRow());
                    currentRow = TableOffers.RowGroups[0].Rows[currentOfferNo];
                    currentRow.FontSize = 14;


                    Paragraph tableServiceEntry = new Paragraph(new Run("client"));
                    tableServiceEntry.TextAlignment = TextAlignment.Center;
                    currentRow.Cells.Add(new TableCell(tableServiceEntry));

                    string tipCamera = "";
                    foreach (var camera in camere)
                        if (camera.Id == rezervare.IdCamera)
                        {
                            tipCamera = tipCamera + camera.Nume;
                            break;
                        }

                    tableServiceEntry = new Paragraph(new Run(tipCamera));
                    tableServiceEntry.TextAlignment = TextAlignment.Center;
                    currentRow.Cells.Add(new TableCell(tableServiceEntry));


                    tableServiceEntry = new Paragraph(new Run(rezervare.NrCamere.ToString()));
                    tableServiceEntry.TextAlignment = TextAlignment.Center;
                    currentRow.Cells.Add(new TableCell(tableServiceEntry));



                    string tipOferta = "";
                    foreach (var oferta in oferte)
                        if (oferta.Id == rezervare.IdOferta)
                        {
                            tipOferta = tipOferta + oferta.Nume;
                            break;
                        }
                    tableServiceEntry = new Paragraph(new Run(tipOferta));
                    tableServiceEntry.TextAlignment = TextAlignment.Center;
                    currentRow.Cells.Add(new TableCell(tableServiceEntry));


                    tableServiceEntry = new Paragraph(new Run(rezervare.DataStart.ToString()));
                    tableServiceEntry.TextAlignment = TextAlignment.Center;
                    currentRow.Cells.Add(new TableCell(tableServiceEntry));

                    tableServiceEntry = new Paragraph(new Run(rezervare.DataEnd.ToString()));
                    tableServiceEntry.TextAlignment = TextAlignment.Center;
                    currentRow.Cells.Add(new TableCell(tableServiceEntry));

                    currentOfferNo++;
                }
            }

        }
    }
}
