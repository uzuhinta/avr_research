/*
 * Control_LED.c
 *
 * Created: 29-Oct-19 3:09:07 PM
 * Author : quann
 */ 

#include <avr/io.h>
#include <avr/interrupt.h>
#include <util/delay.h>

//chuong trinh chon truyen du lieu
void led_control(unsigned char chr)
{
	PORTB = chr;
}

void sent_data(unsigned char chr)
{
	//while (bit_is_clear(UCSRA, UDRE));
	//UDR = chr;
	
	//while (bit_is_clear(UCSRA,UDRE)) {}; //cho den khi bit UDRE=1
	while(!(UCSRA & (1 << UDRE)));
	UDR=chr;
}

volatile unsigned char u_Data;
//bi?n l?u giá tr? PINB c? và nh?n giá tr? ki?m tra ban ??u.
volatile unsigned char data_sent = 0x80;

int main(void)
{
    //set khung truyen 57600
	UBRRH = 0;
	UBRRL =8;
	//set cong xuat B
	DDRB = 0xFF;
	
	//SET THANH GHI nhap xuat 8 bit
	UCSRA = 0x00;
	UCSRC = (1<<URSEL)|(1<<UCSZ1) | (1<<UCSZ0);
	UCSRB = (1<<RXCIE)|(1<<RXEN) |(1<<TXEN);
	sei();
	
	//sent_data(PINB);
	
    while (1)
	{
		if(data_sent != (char)PINB)
		{
			sent_data(PINB);
			_delay_ms(500);
			data_sent = (char)PINB;
		}
	}
}

ISR(USART_RXC_vect){
	u_Data = UDR;
	if(u_Data == 0x80)
	{
		sent_data(PINB);
	}
	else
	{
		PORTB = u_Data;
	}

	//led_control(u_Data);
}



