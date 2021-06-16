module Requests
    module JsonhHelpers
        def json
            JSON.parse(response.body)
        end
    end
end