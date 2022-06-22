using System;
using Xamarin.Forms;

namespace Xamurai.TemplateSelectors
{
    public class CarDataTemplateSelector : DataTemplateSelector
    {

        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate MercedesTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Car car = item as Car;
            if (car.Make == CarMake.Mercedes)
            {
                return MercedesTemplate;
            }
            return DefaultTemplate;
        }
    }
}