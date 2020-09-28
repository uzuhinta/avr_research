#include <avr/io.h>
#include <avr/interrupt.h>
#include <util/delay.h>

int main(void){
	DDRB=0xFF;//C?NG B LÀ C?NG XU?T
	PORTB=0x00;

	TCCR0=(1<<CS01);//THI?T L?P B? CHIA PRESCALER = 8
	TCNT0=131;//GÁN GIÁ TR? KH?I T?O CHO T/C0
	TIMSK=(1<<TOIE0);//CHO PHÉP NG?T KHI CÓ TRÀN ? T/C0
	sei();//CHO PHÉP NG?T TOÀN C?C
	while (1){
	}
	return 0;
}

//TRÌNH PH?C V? NG?T TRÀN ? T/C0
ISR (TIMER0_OVF_vect ){
	TCNT0=131;//GÁN GIÁ TR? KH?I T?O CHO T/C0
	PORTB^=1;//??I TR?NG THÁI ? C?NG B.
}