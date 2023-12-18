using NUnit.Framework;

[TestFixture]
public class CuiseurARizTests
{
    [Test]
    public void CuireRiz_ShouldNotThrowExceptions()
    {
        CuiseurARiz cuiseur = new CuiseurARiz();

        Assert.DoesNotThrow(() => cuiseur.CuireRiz());
        Assert.IsFalse(cuiseur.CuissonEnCours);
    }

    [Test]
    public void CuireRiz_WithOverheat_ShouldThrowException()
    {
        CuiseurARiz cuiseur = new CuiseurARiz();
        cuiseur.SurchauffeDetectee = () => true;

        Assert.Throws<Exception>(() => cuiseur.CuireRiz());
        Assert.IsFalse(cuiseur.CuissonEnCours);
    }

    [Test]
    public void MaintienChaud_WithoutCooking_ShouldThrowException()
    {
        CuiseurARiz cuiseur = new CuiseurARiz();

        Assert.Throws<Exception>(() => cuiseur.MaintienChaud());
        Assert.IsFalse(cuiseur.MaintienAuChaud);
    }

    [Test]
    public void MaintienChaud_WithCooking_ShouldNotThrowExceptions()
    {
        CuiseurARiz cuiseur = new CuiseurARiz();
        cuiseur.CuissonEnCours = true;

        Assert.DoesNotThrow(() => cuiseur.MaintienChaud());
        Assert.IsFalse(cuiseur.MaintienAuChaud);
    }

    [Test]
    public void SurchauffeDetectee_ShouldThrowException()
    {
        CuiseurARiz cuiseur = new CuiseurARiz();
        cuiseur.TemperatureActuelle = 130;

        Assert.Throws<Exception>(() => cuiseur.SurchauffeDetectee());
    }

    [Test]
    public void QualiteDuRiz_ShouldReturnTrue()
    {
        CuiseurARiz cuiseur = new CuiseurARiz();

        Assert.IsTrue(cuiseur.QualiteDuRiz());
    }
}
