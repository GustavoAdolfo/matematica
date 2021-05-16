print('Implementação do Algoritmo de Euclides')

numeros = []

num = input('Informe o primeiro numero e tecle ENTER: ')

while len(numeros) < 2:
    try:
        n = int(num)
        numeros.append(n)
        if len(numeros) == 2:
            break
        num = input('Informe o próximo número ou apenas ENTER para finalizar as entradas: ')
    except Exception:
        print('Número inválido')
        num = input('Informe o número ou apenas ENTER para finalizar as entradas: ')

print(numeros)
numeros = sorted(numeros)
print(numeros)
part_int = int(numeros[1] / numeros[0])
diferenca = numeros[1] - (part_int * numeros[0])
ultimo_numero = numeros[0]
print(f'{numeros[1]} / {numeros[0]} = {part_int}')
print(f'Diferença de {diferenca}')
while diferenca > 0:
    part_int = int(ultimo_numero / diferenca)
    prox_numero = diferenca
    diferenca = ultimo_numero - (part_int * diferenca)
    ultimo_numero = prox_numero

print(f'O MDC de {numeros[0]} e {numeros[1]} é {ultimo_numero}')

if '__main__' == __name__:
    pass
