module ReverseWorld
    def self.puts text
        print text.reverse.to_s
    end

    class Impressora
        def call text
            puts text.upcase
            puts "---"
        end
    end
end

ReverseWorld::puts 'subinoonibus'
puts
ReverseWorld::puts 'mas tem que testar né hehe'
puts

impressora = ReverseWorld::Impressora.new
impressora.call('poripá vo ve qual é a dessa fita')