/*
 * timerCounter20.c
 *
 * Created: 02-Oct-19 9:34:59 PM
 * Author : quann
 */ 

#include <avr/io.h>
#include <avr/interrupt.h>
#include <util/delay.h>

int main(void)
{
    DDRB = 0xFF;//THI?T L?P C?NG B LÀ C?NG XU?T
	PORTB = 0x00;//THI?T L?P GIÁ TR? ??U
	
	TCCR1B =(1<<CS10)|(1<<CS11);//CH?N MODE HO?T ??NG
	TCNT1 = 49910;//KH?I T?O GIÁ TR? ??U CHO T/C1
	TIMSK = (1<<TOIE1);//CHO PHÉP NG?T KHI CÓ TRÀN ? T/C1
	sei();//CHO PHÉP NG?T TOÀN C?C
    while (1) 
    {
		
    }
}
//CH??NG TRÌNH PH?C V? NG?T T/C1
ISR(TIMER1_OVF_vect){
	TCNT1 = 49910;//KH?I T?O GIÁ TR? ??U CHO T/C1
	PORTB ^= 1;//??O GIÁ TR? ? C?NG B.
}

