namespace DevNotes.Library
{
    public class LINQ
    {
        List<TaxRate> taxTypes = new List<TaxRate>() {
            new TaxRate{Name = "ORD", Ratio = 21 },
            new TaxRate{Name = "RED", Ratio = 12 },
            new TaxRate{Name = "SUP", Ratio = 4 },
        };

        List<Invoice> invoices = new List<Invoice>()
        {
            new Invoice{Id = 1, TotalInvoice = 126320, VatType = "ORD" },
            new Invoice{Id = 2, TotalInvoice = 134202, VatType = "RED" },
            new Invoice{Id = 3, TotalInvoice = 134202, VatType = "RED" },
            new Invoice{Id = 4, TotalInvoice = 134202, VatType = "MOC" },
            new Invoice{Id = 5, TotalInvoice = 134202, VatType = "MOC" },
        };

        public TaxRate HeighestRate(List<TaxRate> taxTypes, List<Invoice> invoices)
        {
            var taxInInvoices = invoices.Select(e => e.VatType).ToList();
            var taxTypeFiltered = taxTypes.Where(e => taxInInvoices.Contains(e.Name)).ToList();

            var taxHeighest = taxTypeFiltered.OrderBy(e => e.Ratio).FirstOrDefault();

            return taxHeighest!;
        }

        public TaxRate MinimumRate(List<TaxRate> taxTypes, List<Invoice> invoices)
        {
            var taxInInvoices = invoices.Select(e => e.VatType).ToList();
            var taxTypeFiltered = taxTypes.Where(e => taxInInvoices.Contains(e.Name)).ToList();

            var taxMinimum = taxTypeFiltered.OrderByDescending(e => e.Ratio).FirstOrDefault();

            return taxMinimum!;
        }

    }

    public class TaxRate
    {
        public string Name { get; set; } = string.Empty;
        public int Ratio { get; set; }
    }

    public class Invoice
    {
        public int Id { get; set; }
        public int TotalInvoice { get; set; }
        public string VatType { get; set; } = string.Empty;
    }
}
