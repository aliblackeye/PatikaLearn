from tkinter import Y

yedekliste = []
    
# duzlestirdigim kisim

def flat(l):
    for i in l:
        if type(i)==list: #i'nin tipi liste oldugu surece calismaya devam eder. 
                            #  liste olmadigi yerde yedeklisteye ekler
            flat(i)

        else:
            yedekliste.append(i)

flat([["ali",["ata"],[[[["bak"]]]]],2022,["patika.dev"]])

print(yedekliste)

# ters cevirme islemi

x = [[1, 2], [3, 4], [5, 6, 7]]
yedek = []

def terscevir(l):
    for i in l:
        if type(i)==list:
            yedek.append(list(reversed(i)))
            
            
    
terscevir([[1, 2], [3, 4], [5, 6, 7]])
print(list(reversed(yedek)))