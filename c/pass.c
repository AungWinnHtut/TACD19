#include<stdio.h>
#include<conio.h>
int main()
{
	int pass;
	int count=0;

	do{
		printf("please enter password ");
		scanf("%d",&pass);
		if(pass==323)
		{
			printf("\nOK");
		}
		else{
			count++; //count=count+1;
			if(count>=3)
			{
				return 0;
			}
		}

	}while(pass!=323);
	getch();
	return 0;
}