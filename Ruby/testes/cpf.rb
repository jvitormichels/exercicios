require 'cpf_cnpj'

loop do
    print "Deseja gerar um novo cpf? (s/n) "
    resposta = gets.chomp

    if resposta == 's' || resposta == 'S'
        cpf = CPF.new(10550792970)
        puts "#{CPF.valid?(cpf)}"
        puts "#{cpf.formatted}"
    else
        break
    end
end