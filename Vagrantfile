# -*- mode: ruby -*-
# vi: set ft=ruby :

Vagrant.configure("2") do |config| 
  config.vm.define :servidorParcial do |servidorParcial|
   servidorParcial.vm.box = "bento/ubuntu-20.04"
   servidorParcial.vm.network :private_network, ip: "192.168.50.3"
   servidorParcial.vm.provision "shell", path: "dashboard.sh"
   servidorParcial.vm.hostname = "servidorParcial"
  end
 end