using System.ComponentModel.DataAnnotations;

namespace ApproachToCleanCode.SOLID.OpenClosedPrinciple;

// Formatlama işlemini genel hatlarıyla tanımlayan bir ata sınıf tanımlayarak asıl işleri de türetilmiş sınıflara devrettik.
// XmlFormatter eklenmek istendiğinde ilgili class ının PrettyFormatProvider dan türetilerek yazılması yeterli olacak.
// Diğer classlar bu geliştirmeden etkilenmeyecekler. Böylelikle classlar gelişime açık, değişime kapalı olacaklar.

// Soyut kontrat sınıfı (Ata Sınıf)
public abstract class PrettyFormatProvider
{
    public abstract string Format(string input);
}

// Somut özelleşmiş sınıf (Türetilmiş Sınıf)
public class JsonFormatter : PrettyFormatProvider
{
    private JsonValidator _validator = new JsonValidator();

    public override string Format(string input)
    {

        if (!_validator.IsValid(input))
            throw new ValidationException();

        // Formatlama işlemini yap
        return "formatlanmış metin!";
    }
}

// Somut özelleşmiş sınıf (Türetilmiş Sınıf)
public class HtmlFormatter : PrettyFormatProvider
{
    private HtmlValidator _validator = new HtmlValidator();

    public override string Format(string input)
    {

        if (!_validator.IsValid(input))
            throw new ValidationException();

        // Formatlama işlemini yap
        return "formatlanmış metin!";
    }
}

public class JsonValidator
{
    public bool IsValid(string input)
    {
        return true;
    }
}

public class HtmlValidator
{
    public bool IsValid(string input)
    {
        return true;
    }
}