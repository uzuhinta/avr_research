#include <avr/io.h>
#include <avr/interrupt.h>
#include <util/delay.h>

//CH??NG TRÌNH CON PHÁT D? LI?U RA MÀN HÌNH
void uart_char_tx(unsigned char chr){
      while (bit_is_clear(UCSRA,UDRE)) {};//
       UDR=chr;
}
volatile unsigned char u_Data;//BI?N L?U GIÁ TR? NH?N ???C

int main(void){
	//THI?T L?P T?C ?? TRUY?N 57600K ?NG V?I F = 8MHZ
      UBRRH=0;
      UBRRL=8;
	  //THI?T L?P THÔNG S? KHÁC VÀ KÍCH HO?T B? TRUY?N, NH?N D? LI?U
      UCSRA=0x00;
      UCSRC=(1<<URSEL)|(1<<UCSZ1)|(1<<UCSZ0);
      UCSRB=(1<<RXEN)|(1<<TXEN)|(1<<RXCIE);//CHO PHÉP C? TRUY?N VÀ NH?N, NG?T SAU KHI NH?N D? LI?U
       sei(); ////CHO PHÉP NG?T TOÀN C?C
      while(1){      }
}
//TRÌNH PH?C V? NGÁT USART
ISR(USART_RXC_vect){
       u_Data=UDR;
      uart_char_tx(u_Data);
}