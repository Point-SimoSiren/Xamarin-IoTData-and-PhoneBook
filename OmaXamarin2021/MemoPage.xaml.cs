using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OmaXamarin2021
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MemoPage : ContentPage
    {

        public IList<Contact> datagrids { get; set; }

        public MemoPage()
        {
            InitializeComponent();
            datagrids = new List<Contact>();
            datagrids.Add(new Contact() { Nimi= "Simo", Puhelin= "0509102224" });
            datagrids.Add(new Contact() { Nimi = "Jani", Puhelin = "04423824784" });
            datagrids.Add(new Contact() { Nimi = "Michelle", Puhelin = "0502339292" });
            datagrids.Add(new Contact() { Nimi = "Joonas", Puhelin = "0403233244" });
            BindingContext = this;
        }
        public class Contact
        {
            public string Nimi { get; set; }
            public string Puhelin { get; set; }
        }
    }
}