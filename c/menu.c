#include<stdio.h>
#include<conio.h>
#include<process.h>
int main()
{
	int ans;
	do{
		system("cls");
		printf("0-exit\n");
		printf("1-area\n");
		printf("2-gold\n");
		printf("please enter your choice: ");
		scanf("%d",&ans);
		switch(ans)
		{
			case 0: return 0;
			case 1: printf("area\n"); getch();break;
			case 2: printf("gold\n"); getch();break;
			default: printf("wrong answer. please choose only 1, 2, 3 \n"); getch(); break;

		}
	}while(ans!=0);


	return 0;
}