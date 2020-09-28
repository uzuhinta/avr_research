/*
 * ADC.c
 *
 * Created: 09-Oct-19 12:25:02 AM
 * Author : quann
 */ 

#include <avr/io.h>
#include <util/delay.h>

#define ARER_MODE 0 //DIEN AP THAM CHIEU NGOAI, CHAN VREF
#define AVCC_MODE (1<<REFS0) //DIEN AP THAM CHIEU AVCC
#define INT_MODE (1<<REFS1)|(1<<REFS0)//DIEN AP THAM CHIEU NOI 2.56V
#define ADC_VREF_TYPE AVCC_MODE//DINH NGHIA KIEU DIEN AP THAM CHIEU

uint16_t ADC_val;
uint16_t read_adc(unsigned char adc_channel){//doc ADC theo tung channel
	ADMUX=adc_channel|ADC_VREF_TYPE;
	ADCSRA|=(1<<ADSC);
	loop_until_bit_is_set(ADCSRA, ADIF);
	return ADCW;
}

void LED7_out(uint16_t val){//xuat data ra led 7 doan
	uint16_t dvi, chuc, tram, nghin, temp_val;
	temp_val = val;
	nghin = temp_val/1000;
	temp_val-=(1000 *nghin);
	tram = temp_val/100;
	temp_val-=(100*tram);
	chuc=temp_val%10;
	temp_val-=(10*chuc);
	dvi=temp_val - 10*chuc;
	
	PORTB=(chuc<<4)+dvi;
	PORTC=(nghin<<4)+tram;
	
}


int main(void)
{
    ADCSRA=(1<<ADEN)|(1<<ADPS2)|(1<<ADPS0);//enable ADC
	ADMUX=ADC_VREF_TYPE;
	
	DDRB=0xFF;
	DDRC=0xFF;
    while (1) 
    {
		ADC_val = read_adc(0);
		LED7_out(ADC_val);
		_delay_ms(100);
    }
}

