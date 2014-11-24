ARGF.readlines.each do |line|
  l = line.gsub('<br>', '').strip
  next if l.empty?
  puts l
end
