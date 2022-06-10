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
    /// <summary>
    /// Interaction logic for ViewServicesPage.xaml
    /// </summary>
    public partial class ViewServicesPage : Window
    {
        public ViewServicesPage()
        {
            InitializeComponent();
            CreateTable();
        }

        public void CreateTable()
        {
            int numberOfColumns = 2;
            for (int x = 0; x < numberOfColumns; x++)
            {
                TableServices.Columns.Add(new TableColumn());
            }
            TableServices.RowGroups.Add(new TableRowGroup());
            TableServices.RowGroups[0].Rows.Add(new TableRow());
            TableRow currentRow = TableServices.RowGroups[0].Rows[0];

            //Table Title
            currentRow.FontSize = 24;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Servicii hotel"))));
            currentRow.Cells[0].ColumnSpan = 2;

            //Header Row
            TableServices.RowGroups[0].Rows.Add(new TableRow());
            currentRow = TableServices.RowGroups[0].Rows[1];
            currentRow.FontSize = 18;

            Paragraph tableHeader = new Paragraph(new Run("Denumire serviciu"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));

            tableHeader = new Paragraph(new Run("Pret serviciu"));
            tableHeader.TextAlignment = TextAlignment.Center;
            currentRow.Cells.Add(new TableCell(tableHeader));


            using (var dbContext = new BookingContext())
            {
                ServiciuRepository serviciuRepository = new ServiciuRepository(dbContext);
                List<Serviciu> servicii = serviciuRepository.GetServicii();
                int currentServiceNo = 2;
                RemoveServiceViewModel removeServicesViewModel = new RemoveServiceViewModel();
                foreach (var serviciu in servicii)
                {
                    if (removeServicesViewModel.Servicii.Contains(serviciu.Nume))
                    {
                        TableServices.RowGroups[0].Rows.Add(new TableRow());
                        currentRow = TableServices.RowGroups[0].Rows[currentServiceNo];
                        currentRow.FontSize = 14;

                        Paragraph tableServiceEntry = new Paragraph(new Run(serviciu.Nume));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));

                        tableServiceEntry = new Paragraph(new Run(serviciu.Pret.ToString()));
                        tableServiceEntry.TextAlignment = TextAlignment.Center;
                        currentRow.Cells.Add(new TableCell(tableServiceEntry));

                        currentServiceNo++;
                    }
                }
            }

        }
    }
}
