class Fish
    def method_missing(method_name)
        puts "Fish doesn't have #{method_name} behavior"
    end

    def swim
        puts "The fish is swimming"
    end
end

peixonauta = Fish.new
peixonauta.swim()
peixonauta.walk()
peixonauta.runBoy()