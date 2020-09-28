/*
 * the watchdog timer.c
 *
 * Created: 16-Oct-19 2:37:33 PM
 * Author : quann
 */ 

#include <avr/io.h>
#define 	wdt_reset()   __asm__ __volatile__("wdr");

static unsigned int waiter;

int main(void)
{
    DDRC = 0x1;
	
	while(PINA == 1)
	{
		;
	}
	
	WDTCR = 0x0B;
	
	while(PINA == 0){
		wdt_reset();
		++waiter;
		if (waiter == 50000)
		{
			PORTC = PORTC ^ 1;
			waiter = 0;
		}
	}
    while (1) 
    {
    }
}

