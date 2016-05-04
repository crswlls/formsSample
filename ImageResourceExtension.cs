using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace formsSample
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source {get;set;}

        #region IMarkupExtension implementation
        public object ProvideValue (IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            return ImageSource.FromResource(Source);
        }
        #endregion
        
    }
}

