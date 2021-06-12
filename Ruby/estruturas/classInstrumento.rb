class Instrumento
    def escrever
        puts "Escrevendo"
    end
end

class Caneta < Instrumento
    def escrever
        puts "Escrevendo à caneta"
    end
end

class Lapis < Instrumento
end

class Teclado < Instrumento
    def escrever
        super
        puts "só que no compiuterkkkk"
    end
end

instrumento = Instrumento.new
instrumento.escrever()

caneta = Caneta.new
caneta.escrever()

lapis = Lapis.new
lapis.escrever()

teclado = Teclado.new
teclado.escrever()