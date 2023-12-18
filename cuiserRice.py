import time

class CuiseurARiz:
    def __init__(self):
        self.cuisson_en_cours = False
        self.maintien_au_chaud = False
        self.temps_maintien_au_chaud = 30
        self.surchauffe_temperature = 120

    def cuire_riz(self):
        try:
            print("Cuisson en cours...")
            self.cuisson_en_cours = True

            for _ in range(15):
                time.sleep(1)
                if self.surchauffe_detectee():
                    raise Exception("Surchauffe détectée. Arrêt de la cuisson.")
            if not self.qualite_du_riz():
                raise Exception("Le riz ne répond pas aux critères de qualité.")
        except Exception as e:
            print(f"Erreur pendant la cuisson : {str(e)}")
        finally:
            self.cuisson_en_cours = False

    def maintien_chaud(self):
        try:
            if self.cuisson_en_cours:
                print(f"Le riz est maintenant maintenu au chaud pendant {self.temps_maintien_au_chaud} secondes.")
                self.maintien_au_chaud = True
                time.sleep(self.temps_maintien_au_chaud)
                print("Le maintien au chaud est terminé.")
                self.maintien_au_chaud = False
            else:
                raise Exception("Aucune cuisson en cours. Commencez d'abord la cuisson.")
        except Exception as e:
            print(f"Erreur pendant le maintien au chaud : {str(e)}")

    def surchauffe_detectee(self):
        temperature_actuelle = 130
        if temperature_actuelle >= self.surchauffe_temperature:
            return True
        return False

    def qualite_du_riz(self):
        return True
