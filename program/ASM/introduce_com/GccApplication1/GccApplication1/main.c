/*
 * GccApplication1.c
 *
 * Created: 14-Oct-19 1:28:33 PM
 * Author : quann
 */ 

#include <avr/io.h>
#include <avr/interrupt.h>
#include <util/delay.h>
#include <stdio.h>
#include "myLCD.h"

//Chuong trinh con phat ki tu uart(ham co ban)
void uart_char_tx(unsigned char chr){
	if(chr == '\n') uart_char_tx('\r');
	while(bit_is_clear(UCSRA, UDRE)){};
	UDR = chr;
}

//tao 2 file(stream) tuong ung LCD va UART
static FILE ledstd = FDEV_SETUP_STREAM(putChar_LCD, NULL, _FDEV_SETUP_WRITE);
static FILE uartstd = FDEV_SETUP_STREAM(uart_char_tx, NULL, _FDEV_SETUP_WRITE);
int main(void)
{
    //uart set baud, 38.4 ung voi f=8mhz
	UBRRH = 0;
	UBRRL = 12;
	UCSRA = 0x00;
	UCSRC = (1 << URSEL)|(1 << UCSZ1)|(1 << UCSZ0);
	UCSRB = (1 << RXEN)|(1 << TXEN)|(1 << RXCIE);//cho phep ngat RxD
	sei();//cho phep ngat toan cuc
	//LCD: khoi dong va in LCD
	init_LCD();
	clr_LCD();
	int x = 8205;
	printf("In lan 1");
	fprintf(&ledstd, "Nguyen Ba Quan");
	move_LCD(2, 1);
	printf("In lan 3: %i", x);
	stdout = &ledstd;
	printf("In lan 4: %i", x);
	//in ra uart
	stdout=&uartstd;
	printf("Hello Quan\n");
	fprintf(&uartstd, "11111111111111111111 %i", 1708);
	printf("Hay nhap 1 phim dien kiem tra ASCII\n");
    while (1) 
    {
    }
}

ISR(USART_RXC_vect){
	fprintf(&uartstd, "Ma ASCII: %i \n", UDR);
}


