using System;

class CuiseurARiz
{
    private bool cuissonEnCours = false;
    private bool maintienAuChaud = false;
    private int tempsMaintienAuChaud = 30;
    private int surchauffeTemperature = 120;

    public void CuireRiz()
    {
        Console.WriteLine("Cuisson en cours...");
        cuissonEnCours = true;
        try
        {
            for (int i = 0; i < 15; i++)
            {
                System.Threading.Thread.Sleep(1000);
                if (SurchauffeDetectee())
                    throw new Exception("Surchauffe détectée. Arrêt de la cuisson.");
            }
            if (!QualiteDuRiz())
                throw new Exception("Le riz ne répond pas aux critères de qualité.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erreur pendant la cuisson : {e.Message}");
        }
        finally
        {
            cuissonEnCours = false;
        }
    }

    public void MaintienChaud()
    {
        if (!cuissonEnCours)
        {
            throw new Exception("Aucune cuisson en cours. Commencez d'abord la cuisson.");
        }

        Console.WriteLine($"Le riz est maintenant maintenu au chaud pendant {tempsMaintienAuChaud} secondes.");
        maintienAuChaud = true;
        System.Threading.Thread.Sleep(tempsMaintienAuChaud * 1000);
        Console.WriteLine("Le maintien au chaud est terminé.");
        maintienAuChaud = false;
    }

    private bool SurchauffeDetectee()
    {
        int temperatureActuelle = 130;
        if (temperatureActuelle >= surchauffeTemperature)
        {
            throw new Exception("Surchauffe détectée. Arrêt de la cuisson.");
        }
        return false;
    }

    private bool QualiteDuRiz()
    {
        return true;
    }
}

class Program
{
    static void Main()
    {
        CuiseurARiz cuiseur = new CuiseurARiz();

        try
        {
            cuiseur.CuireRiz();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erreur générale pendant la cuisson : {e.Message}");
        }

        try
        {
            cuiseur.MaintienChaud();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erreur générale pendant le maintien au chaud : {e.Message}");
        }
    }
}
