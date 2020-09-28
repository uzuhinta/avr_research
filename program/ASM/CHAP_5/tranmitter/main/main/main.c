#include <avr/io.h>
#include <avr/delay.h>

//CH??NG TRÌNH CON PHÁT D? LI?U
void uart_char_tx(unsigned char chr){
	while (bit_is_clear(UCSRA,UDRE)) {};//L?P CHO ??N KHI UDRE != 1
	UDR=chr;//GHI D? LI?U ?? TRUY?N ?I
}

int main(void){
	//THI?T L?P T?C ?? TRUY?N 57600K ?NG V?I F = 8MHZ
	UBRRH=0;
	UBRRL=8;
	
	//THI?T L?P KHUNG TRUY?N VÀ KÍCH HO?T B? TRUY?N D? LI?U
	UCSRA=0x00;
	UCSRC=(1<<URSEL)|(1<<UCSZ1)|(1<<UCSZ0);
	UCSRB=(1<<TXEN);
	
	while(1){
		for (char i=32; i<128; i++){
			uart_char_tx(i);//PHÁT
			_delay_ms(100);
		}
	}
}