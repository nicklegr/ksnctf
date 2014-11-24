require 'base64'

out = ARGF.read

16.times do
  out = Base64.decode64(out)
end

# puts out
File.binwrite("problem.dat", out)
