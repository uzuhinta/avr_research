/*
 * timerCounter21.c
 *
 * Created: 02-Oct-19 10:10:01 PM
 * Author : quann
 */ 

#include <avr/io.h>


#include <avr/io.h>
#include <avr/interrupt.h>
#include <util/delay.h>
volatile  unsigned char val=0;//KHAI BÁO BI?N VAL ?? GI? GIÁ TR? XU?T RA C?NG B  
int main(void){
	DDRB=0xFF;//THI?T L?P C?NG B LÀ C?NG XU?T.
	PORTB=0x00;//GIÁ TR? ??U C?A C?NG = 0
	TCCR1B=(1<<WGM12)|(1<<CS12)|(1<<CS11);//CH?N MODE CHO T/C 1 C? TH? CTC4
	OCR1A=4;//GÁN GIÁ TR? C?N SO SÁNH 
	TIMSK=(1<<OCIE1A);//CHO PHÉP NG?T KHI GIÁ TR? ??M B?NG OCR1A
	sei();//CHO PHÉP NG?T TOÀN C?C 
	while (1){ 
		//do nothing
	}
	return 0;
}
//TRÌNH PH?C V? NG?T T/C1 KHI COMPARE MATCH.
ISR (TIMER1_COMPA_vect){
	val++;
	if (val==10) val=0;//GI?I H?N BI?N VAL N?M TRONG 0 ??N 9
	PORTB =val;//XU?T GIÁ TR? VAL RA C?NG B.     
}
