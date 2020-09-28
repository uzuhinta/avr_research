/*
 * Master.c
 *
 * Created: 08-Oct-19 1:00:30 AM
 * Author : quann
 */ 

#include <avr/io.h>
#include <util/delay.h>
#include <avr/interrupt.h>

volatile unsigned char u_data = 0;
void uart_char_tx(unsigned char ch);
void uart_address_tx(unsigned char ch);

int main(void)
{
    DDRB = 0xFF;
	PORTB = 0;
	
	UBRRH = 0;
	UBRRL = 8;
	
	UCSRA = 0x00;
	UCSRC=(1<<URSEL)|(1<<UCSZ1)|(1<<UCSZ0);
	UCSRB=(1<<TXEN)|(1<<RXEN)|(1<<RXCIE)|(1<<UCSZ2);
	sei();
	
	_delay_ms(1000);
	uart_address_tx(1);
	uart_char_tx(200);
	uart_char_tx(123);
	
	uart_address_tx(2);
	uart_char_tx(100);
	uart_char_tx(254);
    while (1) 
    {
    }
}

void uart_char_tx(unsigned char chr){
	while(!((UCSRA) & (1<<UDRE)));
	UCSRB &= ~(1<<TXB8);
	UDR = chr;
}

void uart_address_tx(unsigned char ch){
	while(!((UCSRA) & (1<<UDRE)));
	UCSRB |= (1<<TXB8);
	UDR = ch;
}

ISR(USART_RXC_vect){
	u_data = UDR;
	PORTB = u_data;
}

