/*
 * period measurement software.c
 *
 * Created: 19-Oct-19 4:51:54 PM
 * Author : quann
 */ 

#include <avr/io.h>
#define period_out PORTC

unsigned char ov_counter; //Counter for timer 1 overflow
unsigned int starting_edge, ending_edge; //storage time
unsigned int clock;//storage for actual clock counts in the pluse

//timer 1 overflow irs
interrupt [TIMER1_OVF_vect] void timer1_ovf_isr

int main(void)
{
    /* Replace with your application code */
    while (1) 
    {
    }
}

