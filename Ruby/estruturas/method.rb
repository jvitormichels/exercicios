def limparTela
    system("clear")
end

def modulo(n1, n2)
    if n1 > n2
        resultado = n1 - n2
    else
        resultado = n2 - n1
    end
    return resultado
end

puts "#{modulo(-3, 5)}"