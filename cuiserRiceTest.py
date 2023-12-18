import unittest
from unittest.mock import patch
from cuiserRice import CuiseurARiz  

class TestCuiseurARiz(unittest.TestCase):

    def setUp(self):
        self.cuiseur = CuiseurARiz()

    def test_cuire_riz_with_good_quality(self):
        with patch('builtins.print') as mock_print:
            self.cuiseur.cuire_riz()
            self.assertFalse(self.cuiseur.cuisson_en_cours)
            mock_print.assert_called_with("Cuisson en cours...")

    def test_cuire_riz_with_bad_quality(self):
        with patch('builtins.print') as mock_print:
            with self.assertRaises(Exception) as context:
                self.cuiseur.qualite_du_riz = lambda: False
                self.cuiseur.cuire_riz()
            self.assertEqual(str(context.exception), "Le riz ne répond pas aux critères de qualité.")
            self.assertFalse(self.cuiseur.cuisson_en_cours)

    def test_cuire_riz_with_overheat(self):
        with patch('builtins.print') as mock_print:
            with self.assertRaises(Exception) as context:
                with patch.object(self.cuiseur, 'surchauffe_detectee', return_value=True):
                    self.cuiseur.cuire_riz()
            self.assertEqual(str(context.exception), "Surchauffe détectée. Arrêt de la cuisson.")
            self.assertFalse(self.cuiseur.cuisson_en_cours)

    def test_maintien_chaud_with_no_cooking(self):
        with patch('builtins.print') as mock_print:
            with self.assertRaises(Exception) as context:
                self.cuiseur.maintien_chaud()
            self.assertEqual(str(context.exception), "Aucune cuisson en cours. Commencez d'abord la cuisson.")
            self.assertFalse(self.cuiseur.maintien_au_chaud)

    def test_maintien_chaud_with_cooking(self):
        with patch('builtins.print') as mock_print:
            self.cuiseur.cuisson_en_cours = True
            self.cuiseur.maintien_chaud()
            mock_print.assert_called_with(f"Le riz est maintenant maintenu au chaud pendant {self.cuiseur.temps_maintien_au_chaud} secondes.")
            mock_print.assert_called_with("Le maintien au chaud est terminé.")
            self.assertFalse(self.cuiseur.maintien_au_chaud)

    def test_surchauffe_detectee(self):
        self.assertTrue(self.cuiseur.surchauffe_detectee())

    def test_qualite_du_riz(self):
        self.assertTrue(self.cuiseur.qualite_du_riz())

if __name__ == '__main__':
    unittest.main()
