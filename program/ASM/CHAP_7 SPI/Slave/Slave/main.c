/*
 * Slave.c
 *
 * Created: 02-Nov-19 2:21:45 PM
 * Author : quann
 */ 

#include <avr/io.h>
#include <util/delay.h>
#include <avr/interrupt.h>
#include <stdio.h>
#include "myLCD.h"

//??NH NGH?A CÁC ???NG GIAO TI?P SPI, PH? THU?C C?U TRÚC CHÂN T?NG CHIP
#define SPI_PORT PORTB
#define SPI_DDR DDRB
#define  SCK_PIN 7
#define MISO_PIN 6
#define MOSI_PIN 5
#define SS_PIN 4

volatile unsigned char wData = 16, rData;
volatile 	uint8_t dis[5];;

void SPI_SlaveInit(void){
	SPI_DDR |= (1 <<MISO_PIN);
	SPI_PORT |= (1<<MOSI_PIN)|(1<<SS_PIN);
	SPCR = (1<<SPIE)|(1<<SPE)|(1<<CPHA)|(1<<SPR1)|(1<<SPR0);
}

int main(void)
{
	sei();
	SPI_SlaveInit();
	DDRD = 0xFF;
	init_LCD();
	clr_LCD();
	
    while (1) 
    {
    }
}
//CH??NG TRÌNH PH?C V? NG?T TRÊN SPI
ISR(SPI_STC_vect){
	rData = SPDR;
	clr_LCD();

	sprintf(dis, "%i", rData);
	move_LCD(1,1);
	print_LCD(dis);
}
