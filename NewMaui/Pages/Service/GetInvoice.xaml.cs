namespace NewMaui.Pages.Service;
using NewMaui.Data;
using NewMaui.Model;
using System.ComponentModel;

public partial class GetInvoice : ContentPage, INotifyPropertyChanged
{
        private readonly InvoiceData invoiceDataApi;
    private Invoice invoice;

    public Invoice Invoice
    {
        get => invoice;
        set
        {
            if (invoice != value)
            {
                invoice = value;
                OnPropertyChanged(nameof(Invoice));
            }
        }
    }
    public GetInvoice()
        {
            InitializeComponent();
            invoiceDataApi = new InvoiceData();
            Invoice = new Invoice();
            BindingContext = Invoice; // Set the binding context to the page itself
        }

    private async void OnButtonClickedInvoice(object sender, EventArgs e)
    {
        if (int.TryParse(serviceIDEntry.Text, out int serviceID))
        {
            List<Invoice> retrievedInvoices = await invoiceDataApi.GetInvoiceDataAsync(serviceID);

            if (retrievedInvoices != null && retrievedInvoices.Count > 0)
            {
                Invoice retrievedInvoice = retrievedInvoices[0];
                // Update the Invoice properties directly
                Invoice.serviceDate = retrievedInvoice.serviceDate;
                Invoice.totalPartsName = retrievedInvoice.totalPartsName;
                Invoice.workTimeUsed = retrievedInvoice.workTimeUsed;
                Invoice.workPrice = retrievedInvoice.workPrice;
                Invoice.transportTimeUsed = retrievedInvoice.transportTimeUsed;
                Invoice.transportTimePrice = retrievedInvoice.transportTimePrice;
                Invoice.transportKmUsed = retrievedInvoice.transportKmUsed;
                Invoice.transportKmPrice = retrievedInvoice.transportKmPrice;
                Invoice.totalPrice = retrievedInvoice.totalPrice;
            }
            else
            {
                // Clear the Invoice properties if no invoice is retrieved
                Invoice.serviceDate = default;
                Invoice.totalPartsName = string.Empty;
                Invoice.workTimeUsed = default;
                Invoice.workPrice = default;
                Invoice.transportTimeUsed = default;
                Invoice.transportTimePrice = default;
                Invoice.transportKmUsed = default;
                Invoice.transportKmPrice = default;
                Invoice.totalPrice = default;

                // Notify the UI that the Invoice object has changed
                OnPropertyChanged(nameof(Invoice));
            }
        }
    }



}





