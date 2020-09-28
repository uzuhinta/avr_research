;
; chap1.asm
;
; Created: 27-Sep-19 2:28:54 AM
; Author : quann
;


.CSEG
.INCLUDE "M8DEF.INC"
.ORG 0x000
    RJMP BATDAU

.ORG 0x020
BATDAU:
; KHOI TAO CAC DIEU KIEN DAU
    LDI   R16, HIGH(RAMEND)
    LDI   R17, LOW(RAMEND)
    OUT SPH, R16
    OUT SPL, R17
    LDI   R16, 0xFF;
    OUT DDRB, R16  

; CHUONG TRINH CHINH
LDI R16, $1
MAIN:
	OUT PORTB, R16
	RCALL DELAY
	ROL R16
	RJMP MAIN
; CHUONG TRING CON DELAY 65535 chu ky (khoang 65535us neu  xung ;clock cho chip la 1M)
DELAY:
    LDI R20, 0xFF
    DELAY0:
        LDI R21, 0xFF
        DELAY1:
            DEC R21
            BRNE  DELAY1
        DEC R20
        BRNE DELAY0
RET 