using booking.Database;
using booking.Database.Models;
using booking.Database.Repository;
using booking.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
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
    public partial class ViewOffersPage : Window
    {
        public ViewOffersPage()
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
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Oferte hotel \n"))));
            currentRow.Cells[0].ColumnSpan = 5;

            //Header Row
            TableOffers.RowGroups[0].Rows.Add(new TableRow());
            currentRow = TableOffers.RowGroups[0].Rows[1];
            currentRow.FontSize = 18;

            Paragraph tableHeader = new Paragraph(new Run("Denumire oferta"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Pret oferta"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Nume camera"));
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
                OfertaRepository ofertaRepository = new OfertaRepository(dbContext);
                List<Oferta> oferte = ofertaRepository.GetOferte();
                int currentOfferNo = 2;
                RemoveOfferViewModel removeOfferViewModel = new RemoveOfferViewModel();
                foreach (var oferta in oferte)
                {
                    if (removeOfferViewModel.Oferte.Contains(oferta.Nume))
                    {
                        TableOffers.RowGroups[0].Rows.Add(new TableRow());
                        currentRow = TableOffers.RowGroups[0].Rows[currentOfferNo];
                        currentRow.FontSize = 14;

                        Paragraph tableServiceEntry = new Paragraph(new Run(oferta.Nume));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));

                        tableServiceEntry = new Paragraph(new Run(oferta.Pret.ToString()));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));

                        CameraRepository cameraRepository = new CameraRepository(dbContext);
                        Camera cameraOferta = cameraRepository.GetById(oferta.IdCamera);
                        tableServiceEntry = new Paragraph(new Run(cameraOferta.Nume));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));

                        tableServiceEntry = new Paragraph(new Run(oferta.DataStart.ToString()));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));

                        tableServiceEntry = new Paragraph(new Run(oferta.DataEnd.ToString()));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));

                        currentOfferNo++;
                    }
                }
            }

        }
    }
}
