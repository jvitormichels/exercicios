class Carro
    def getKm(frase)
        km = /\d{1,}kmh/.match(frase)
        if km == nil
            puts "inválido"
        else
            return km
        end
    end
end

frase = "Ela ia à 850kmh no fuscão vermelho"
fusca = Carro.new
velocidade = fusca.getKm(frase)
puts velocidade