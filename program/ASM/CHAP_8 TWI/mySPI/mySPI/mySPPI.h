/*
 * mySPPI.h
 *
 * Created: 11-Nov-19 11:10:58 AM
 *  Author: quann
 */ 


#include <avr/interrupt.h>
#ifdef cbi 
	#define  cbi(port, bit) port &= ~(1 << (bit))
#endif

#ifdef sbi
	#define sbi(port, bit) port |= (1 <<(bit))
#endif

//FOR SLAVER USE
#define GENERAL_CALL			1
#define OWN_ADDRESS_MATCH		0x60 
#define LOST_ADDRESS_MATCH		0x68
#define OWN_DATA_Rec_ACK		0x80	
#define OWN_DATA_Rec_NACK		0x88
#define STOP_Rec				0xA0
#define GENERAL_MATCH			0x70
#define GENERAL_DATA_Rec_ACK	0x90
#define GENERAL_DATA_Rec_NACK	0x98


//FOR SLAVER TRANSMIT
#define ADDRESS_R_MATCH			0xA8
#define LOST_R_MATCH			0xB0
#define DATA_Sent_ACK			0xB8
#define DATA_Sent_NACK			0xC0
#define DATA_Last_Sent_ACK		0xC8

volatile uint8_t Tran_num = 0;
volatile uint8_t SLAVE_wDATA[100];
volatile uint8_t Rect_num = 0;
volatile uint8_t SLAVE_Mode = 0;
volatile uint8_t Device_Addr = 2;
volatile uint8_t SLAVE_Buff[100];

//FOR MASTER USE
#define _222K10
#define _100K32
#define TWI_W			0
#define TWI_R			1
#define TWI_START		(1<<TWINT)|(1<<TWSTA)|(1<<TWEN)
#define TWI_STOP		(1<<TWINT)|(1<<TWSTO)|(1<<TWEN)
#define TWI_Clear_TWINT	(1<<TWINT)|(1<<TWEN)
#define TWI_Read_ACK	(1<<TWINT)|(1<<TWEA)|(1<<TWEN)

#define _START_Sent		0x08 
#define _R_START_Sent	0x10
#define _SLA_W_ACK		0x18
#define _SLA_W_NACK		0x20
#define _DATA_ACK		0x28
#define _DATA_NACK		0x30

#define _SLA_R_ACK		0x40
#define _SLA_R_NACK		0x48
#define _DATA_Rec_ACK	0x50
#define _DATA_Rec_NACK	0x58