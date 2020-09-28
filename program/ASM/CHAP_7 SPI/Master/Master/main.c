/*
 * Master.c
 *
 * Created: 02-Nov-19 1:47:27 PM
 * Author : quann
 */ 

#include <avr/io.h>
#include <util/delay.h>
#include <stdio.h>
#include "myLCD.h"

#define cbi(port, bit) (port) &= ~(1<<(bit))
#define sbi(port, bit) (port) |= (1<<(bit))
//??NH NGH?A CÁC ???NG GIAO TI?P SPI, PH? THU?C T?NG LO?I CHIP
#define SPI_PORT	 PORTB
#define SPI_DDR		 DDRB
#define SCK_PIN		 7
#define MISO_PIN	 6
#define MOSI_PIN	 5

#define ADDRESS_PORT	 PORTB
#define ADDRESS_DDR		 DDRB
#define Slave(i)		 i

volatile uint8_t wData[3] = {0, 80, 160}, dis[];
	
//KH?I ??NG SPI ? CH? ?? MASTER
void SPI_MasterInit(void){
	SPI_DDR |= (1<<SCK_PIN)|(1<<MOSI_PIN);
	SPI_PORT |= (1<<MISO_PIN);//?I?N TR? KÉO LÊN CHO CHÂN MISO.
	SPCR = (1<<SPIE)|(1<<SPE)|(1<<MSTR)|(1<<CPHA)|(1<<SPR1)|(1<<SPR0);
	
	//THI?T L?P CHÂN ?I?U KHI?N CHO SLAVE.
	ADDRESS_DDR |= (1<<Slave(2)) | (1<<Slave(1)) | (1<<Slave(0));
	ADDRESS_PORT |= (1<<Slave(2)) | (1<<Slave(1)) | (1<<Slave(0));
}
//G?I D? LI?U 1 BYTES QUA SPI
void SPI_Transmit(uint8_t i, uint8_t data){
	cbi(ADDRESS_PORT, Slave(i));
	SPDR = data;
	while(bit_is_clear(SPSR, SPIF)){};
	sbi(ADDRESS_PORT, Slave(i));
}

int main(void)
{
    SPI_MasterInit();
	_delay_ms(100);
	while (1) 
    {
		SPI_Transmit(0, wData[0]++);
		if (wData[0] > 80)
		{
			wData[0] = 0;
		}
		_delay_ms(10);
		
		SPI_Transmit(1, wData[1]++);
		if (wData[1] > 160)
		{
			wData[0] = 80;
		}
		_delay_ms(10);
		
		SPI_Transmit(0, wData[0]++);
		if (wData[2] > 240)
		{
			wData[2] = 160;
		}
		_delay_ms(500);
    }
}

