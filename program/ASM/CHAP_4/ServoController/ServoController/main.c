/*
 * ServoController.c
 *
 * Created: 14-Nov-19 2:51:31 PM
 * Author : quann
 */ 

#include <avr/io.h>
#include <avr/interrupt.h>

int main(void)
{
	DDRB = 0xFF;//THI?T L?P C?NG B LÀ C?NG XU?T
	PORTB = 0x00;//??T GIÁ TR? ??U C?A C?NG B
	
	//THI?T L?P MODE C?A T/C1
	MCUCR |= (1<<ISC11)|(1<<ISC01);
	GICR |= (1<<INT1)|(1<<INT0);
	
	TCCR1A |= (1<<COM1A1)|(1<<COM1B1)|(1<<WGM11);
	TCCR1B |= (1<<WGM13)|(1<<WGM12)|(1<<CS10);
	//GÓC QUAY 90 ??
	OCR1A =  1000;
	OCR1B = 1500;
	ICR1 = 20000;
	
	sei();//CHO PHÉP NG?T TOÀN C?C
	while (1)
	{
	}
	
}
//CH??NG TRÌNH PH?C V? NG?T 
ISR(INT0_vect){
	if(OCR1A == 1000) OCR1A = 1500;
	else OCR1A = 1000;
}

ISR(INT1_vect){
	if(OCR1B == 1500) OCR1B = 2000;
	else OCR1B = 1500;
}

