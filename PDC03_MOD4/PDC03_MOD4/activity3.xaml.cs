using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MOD04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity3 : ContentPage
    {
        ObservableCollection<Member> sources = new ObservableCollection<Member>();

        public ObservableCollection<Member> Members { get { return sources; } }
        public activity3()
        {
            InitializeComponent();

            SourceView.ItemsSource = sources;

            sources.Add(new Member { Name = "Vandal", Details = "One Tap", Image = "vandal.jpg" });
            sources.Add(new Member { Name = "Phantom", Details = "Rifle", Image = "phantom.png" });
            sources.Add(new Member { Name = "Drone", Details = "Util", Image = "drone.jpg" });
            sources.Add(new Member { Name = "Singularity", Details = "Skin", Image = "singula.jpg" });
            sources.Add(new Member { Name = "Sova", Details = "Initiator,", Image = "sova.jpg" });
            sources.Add(new Member { Name = "Sova", Details = "Duelist", Image = "jett.png" });
        }
    }
}