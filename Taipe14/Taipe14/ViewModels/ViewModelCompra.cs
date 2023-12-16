using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Taipe14.Models;
using Taipe14.Services;
using Xamarin.Forms;

namespace Taipe14.ViewModels
{
    public class ViewModelCompra : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }

        private string fecha;
        public string Fecha
        {
            get { return this.fecha; }
            set { SetValue(ref this.fecha, value); }
        }

        private string cliente;
        public string Cliente
        {
            get { return this.cliente; }
            set { SetValue(ref this.cliente, value); }
        }

        private string total;
        public string Total
        {
            get { return this.total; }
            set { SetValue(ref this.total, value); }
        }

        private string vendedor;
        public string Vendedor
        {
            get { return this.vendedor; }
            set { SetValue(ref this.vendedor, value); }
        }




        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Compra> compra;
        

        public List<Compra> Compra
        {
            get { return this.compra; }
            set { SetValue(ref this.compra, value); }
        }


        public ICommand SearchCommand { get; set; }
        public ICommand InsertCommand { get; set; }

        public ViewModelCompra()
        {

            SearchCommand = new Command(() =>
            {
                CompraService service = new CompraService();
                Compra = service.GetByText(Filter);


            });

            InsertCommand = new Command(() =>
            {
                CompraService service = new CompraService();
                int newCompraId = service.Get().Count + 1;
                service.Create(new Compra { Fecha = Fecha, Cliente = Cliente, Total = Total, Vendedor = Vendedor, CompraId = newCompraId });

                App.Current.MainPage.DisplayAlert("Success", "Your data are saved", "Ok");
            });


        }


    }
}