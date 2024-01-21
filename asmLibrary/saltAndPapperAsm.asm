.code
addNoise PROC
    ; rcx - wskaznik do tablicy result
    ; rdx - wskaznik do tablicy buffer
    ; r8 - wskaanik do tablicy noise
    ; r9 - liczba bajtów (bytes)

 
    xor rax, rax  ; Zerujemy licznik
    loop_start:
        ; Wczytujemy 16 bajtów z tablicy buffer do xmm0
        movdqu xmm0, [rdx + rax]

        ; Wczytujemy 16 bajtów z tablicy noise do xmm1
        movdqu xmm1, [r8 + rax]

        ; Dodajemy wartsci z xmm0 i xmm1
        paddb xmm0, xmm1

        ; Zapisujemy wynik do tablicy result
        movdqu [rcx + rax], xmm0

        ; Inkrementujemy licznik o 16
        add rax, 16

        ; Sprawdzamy, czy doszlismy do knca tablicy
        cmp rax, r9
        jl loop_start  ; Jezli nie, to powtarzamy petle

        ret
addNoise ENDP

calcGaussian PROC
   ; rcx - wskaznik do tablicy
   ; rdx - wartosc std

    xorps xmm2, xmm2 ; Inicjalizacja xmm2 jako 0 (sum)
     mov r8, 0 ; Licznik petli
     calculate_loop:
        ; Obliczenia wartosci Gaussa
        movd xmm0, r8d ; Wczytaj licznik petli do xmm0
        cvtdq2ps xmm0, xmm0 ; Konwersja na liczbe zmiennoprzecinkowe
        movaps xmm1, xmm0 ; xmm1 = xmm0

        mulps xmm0, xmm0 ; xmm0 = i^2
        mulps xmm0, xmm3 ; xmm0 = -i^2 / (2 * std^2)
        movaps xmm4, xmm2 ; xmm4 = sum
        subps xmm4, xmm0 ; 

        movaps xmm0, xmm1 ; xmm0 = i
        mulps xmm0, xmm5 ; xmm0 = (1 / (sqrt(2 * pi) * std))
        mulps xmm0, xmm4 ; xmm0 = Wartosc Gaussa

        ; Zapisz warto?? Gaussa w tablicy
        movaps [rcx + r8 *8], xmm0 

        ; Aktualizacja sumy
        addps xmm2, xmm0 ; Aktualizacja sumy

        ; Inkrementacja licznika petli
        inc r8
        cmp r8, 256
        jl calculate_loop

     movaps xmm0, xmm2
ret 
calcGaussian ENDP
END