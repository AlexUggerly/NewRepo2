namespace NewMaui.Pages.Service;
using NewMaui.Data;
using NewMaui.Model;

public partial class InvoiceDetails : ContentPage
{

    public InvoiceDetails(int selectedServiceID)
    {
        InitializeComponent();
        LoadInvoiceDataAsync(selectedServiceID);
    }

    public async Task LoadInvoiceDataAsync(int selectedServiceID)
    {
        InvoiceData invoiceData = new InvoiceData();
        List<Invoice> invoices = await invoiceData.GetInvoiceDataAsync(selectedServiceID);
        BindingContext = invoices.FirstOrDefault(); // Set the first invoice as the BindingContext

    }
}