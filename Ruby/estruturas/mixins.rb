module Impressora
    def imprimir texto
        puts "-" * 10
        puts texto
    end
end

module Pernas
    include Impressora
    def chuteLateral
        imprimir 'Chute lateral'
    end

    def rasteira
        imprimir 'Rasteira'
    end
end

module Bracos
    include Impressora
    def jab
        imprimir 'Jab'
    end

    def direto
        imprimir 'Direto'
    end

    def gancho
        imprimir 'Gancho'
    end

    def counter
        imprimir 'Counter!'
    end
end

class Boxeador
    include Bracos
end

class Capoeirista
    include Bracos
    include Pernas
end

ippo = Boxeador.new
zezinho = Capoeirista.new

ippo.jab
zezinho.chuteLateral
ippo.gancho
zezinho.rasteira