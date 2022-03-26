using System.ComponentModel;
using System.Net;

public class MyTypeConverter : TypeConverter
{
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        if (destinationType.Equals(typeof(Image)))
            return true;

        return base.CanConvertTo(context, destinationType);
    }

    public override object ConvertTo(ITypeDescriptorContext context,
        System.Globalization.CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType.Equals(typeof(Image)))
        {
            WebRequest request = System.Net.WebRequest.Create(value + "");

            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    return Bitmap.FromStream(stream);
                }
            }
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }

 
}

