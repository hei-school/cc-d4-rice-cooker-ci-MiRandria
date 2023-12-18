class CuiseurARiz
  def initialize
    @cuisson_en_cours = false
    @maintien_au_chaud = false
    @temps_maintien_au_chaud = 30  
    @surchauffe_temperature = 120  
  end

  def cuire_riz
    puts 'Cuisson en cours...'
    @cuisson_en_cours = true
    15.times do
      sleep(1)
      raise 'Surchauffe détectée. Arrêt de la cuisson.' if surchauffe_detectee
    end
    raise 'Le riz ne répond pas aux critères de qualité.' unless qualite_du_riz
  rescue StandardError => e
    puts "Erreur pendant la cuisson : #{e.message}"
  ensure
    @cuisson_en_cours = false
  end

  def maintien_chaud
    raise "Aucune cuisson en cours. Commencez d'abord la cuisson." unless @cuisson_en_cours

    puts "Le riz est maintenant maintenu au chaud pendant #{@temps_maintien_au_chaud} secondes."
    @maintien_au_chaud = true
    sleep(@temps_maintien_au_chaud)
    puts 'Le maintien au chaud est terminé.'
    @maintien_au_chaud = false
  rescue StandardError => e
    puts "Erreur pendant le maintien au chaud : #{e.message}"
  end

  def surchauffe_detectee
    temperature_actuelle = 130 
    raise 'Surchauffe détectée. Arrêt de la cuisson.' if temperature_actuelle >= @surchauffe_temperature

    false
  end

  def qualite_du_riz
    true
  end
end

cuiseur = CuiseurARiz.new

begin
  cuiseur.cuire_riz
rescue StandardError => e
  puts "Erreur générale pendant la cuisson : #{e.message}"
end

begin
  cuiseur.maintien_chaud
rescue StandardError => e
  puts "Erreur générale pendant le maintien au chaud : #{e.message}"
end
