FROM ubuntu

RUN echo "Asia/Tokyo" > /etc/timezone
RUN dpkg-reconfigure -f noninteractive tzdata

RUN apt-get -y update
RUN apt-get install -y build-essential
RUN apt-get install -y binutils

ADD . /tmp/home
WORKDIR /tmp/home

# RUN objdump -S -d esp
RUN objdump -s -j .rodata esp
