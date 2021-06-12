def capitalizeName(name, surname)
    nameAux = / /.match(name)
    if nameAux == nil
        name = name.capitalize
    else
        firstName = nameAux.pre_match.capitalize
        secondName = nameAux.post_match.capitalize
        name = firstName + ' ' + secondName
    end

    surname = surname.capitalize
    capitalizedName = name + ' ' + surname
    return capitalizedName
end

print "Informe seu nome: "
firstName = gets.chomp
print "Informe seu sobrenome: "
secName = gets.chomp
nome = capitalizeName(firstName, secName)
puts "Ficha
Nome: #{nome}"
