FROM ubuntu

RUN echo "Asia/Tokyo" > /etc/timezone
RUN dpkg-reconfigure -f noninteractive tzdata

RUN echo 'deb http://archive.debian.org/debian-archive/debian etch main' >> /etc/apt/sources.list
RUN apt-get -y update
RUN apt-get install -y build-essential
RUN apt-get install -y binutils
# RUN apt-get install -y --force-yes stegdetect

RUN apt-get install -y git

RUN apt-get install -y unzip
RUN apt-get install -y libmhash-dev libjpeg-dev libmcrypt-dev zlib1g-dev
RUN apt-get install -y steghide

ADD . /tmp/home
WORKDIR /tmp/home

RUN steghide --help
CMD steghide extract -sf mnt/Mona\ Lisa.jpg

# RUN git clone https://github.com/abeluck/stegdetect.git
# WORKDIR stegdetect

# RUN linux32 ./configure
# RUN linux32 make

# RUN unzip steghide-0.5.1.zip

# WORKDIR steghide-0.5.1
# RUN ls -l
# RUN ./configure
# RUN make all install

# RUN objdump -S -d esp
# RUN objdump -s -j .rodata esp
# RUN stegdetect
