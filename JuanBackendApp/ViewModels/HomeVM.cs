using JuanBackendApp.Models;

namespace JuanBackendApp.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Policy> Policies { get; set; }
        public IEnumerable<Banner> Banners { get; set; }
    }
}
