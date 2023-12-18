require 'minitest/autorun'
require_relative './cuiserRice.rb'

class TestCuiseurARiz < Minitest::Test
  def setup
    @cuiseur = CuiseurARiz.new
  end

  def test_cuire_riz
    assert_equal false, @cuiseur.instance_variable_get(:@cuisson_en_cours)
  
    exception = assert_raises(RuntimeError) do
      @cuiseur.cuire_riz
    end
  
    assert_equal "Surchauffe détectée. Arrêt de la cuisson.", exception.message
  
    assert_equal false, @cuiseur.instance_variable_get(:@cuisson_en_cours)
  end
  
  def test_maintien_chaud_avec_cuisson
    @cuiseur.cuire_riz

    assert_equal false, @cuiseur.instance_variable_get(:@maintien_au_chaud)

    @cuiseur.maintien_chaud

    assert_equal false, @cuiseur.instance_variable_get(:@maintien_au_chaud)
  end

  def test_surchauffe_detectee
    assert_equal false, @cuiseur.instance_variable_get(:@cuisson_en_cours)

    assert_raises(StandardError) do
      @cuiseur.surchauffe_detectee
    end
  end

  def test_qualite_du_riz
    assert_equal true, @cuiseur.qualite_du_riz
  end
end