#include <avr/io.h>
#include <util/delay.h>
#include <avr/interrupt.h>
#include <stdio.h>
#include "myLCD.h"

#ifndef cbi
#define  cbi(port, bit) (port) &= ~(1<<(bit))
#endif

#ifndef sbi
#define sbi(port, bit) (port) |= (1<<(bit))
#endif

volatile unsigned char my_address, u_data = 0, ind;
volatile unsigned char alldata[3], dis[5];

int main(void){
	PORTB = 0xFF;
	DDRC = 0x00;
	my_address = PINC & 0x3;
	
	init_LCD();
	//baud rate = 57600
	UBRRH = 0;
	UBRRL = 8;
	
	UCSRA = (1 <<MPCM);
	UCSRC = (1<<URSEL)|(1<<UCSZ1)|(1<<UCSZ0);
	UCSRA = (1<<TXEN)|(1<<RXEN)|(1<<RXCIE)|(1<<UCSZ2);
	
	sei();
	
	_delay_ms(1000);
	
	while(1){
		clr_LCD();
		sprintf(dis, "%i", alldata[1]);
		print_LCD(dis);
		move_LCD(2, 1);
		sprintf(dis, "%i", alldata[2]);
		print_LCD(dis);
		_delay_ms(1000);
	}
}

ISR(USART_RXC_vect){
	u_data = UDR;
	if(ind == 0){
		if(my_address == u_data){
			UCSRA &= ~(1<<MPCM);
			ind++;
		}
	}
	else{
		alldata[ind]= u_data;
		ind++;
		if(ind==3){
			UCSRA |= (1<<MPCM);
			ind=0;
		}
	}
}