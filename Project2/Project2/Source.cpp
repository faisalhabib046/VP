#include<iostream>
using namespace std;

class OS
{
public:
	struct PCB
	{
		PCB *FWD;
		PCB *BKWD;
		int ID;
	};
	PCB pcb[20];
	PCB *Rhead = NULL, *Rtail;
	PCB *Fhead = NULL, *Ftail;
	PCB *Bhead = NULL, *Btail;

	void Initilize_Ready_List(int i)
	{

		if (Rhead == NULL)
		{
			pcb[i].ID = i;
			Rhead = &pcb[i];
			Rtail = &pcb[i];
		}
		else
		{
			pcb[i].ID = i;
			Rtail->FWD = &pcb[i];
			pcb[i].BKWD = Rtail;
			Rtail = &pcb[i];
			Rtail->FWD = NULL;
		}
	}

	void Initilize_Free_List(int i)
	{

		if (Fhead == NULL)
		{
			pcb[i].ID = i;
			Fhead = &pcb[i];
			Ftail = &pcb[i];
		}
		else
		{
			pcb[i].ID = i;
			Ftail->FWD = &pcb[i];
			pcb[i].BKWD = Ftail;
			Ftail = &pcb[i];
			Ftail->FWD = NULL;
		}
	}

	void Initilize_Block_List(int i)
	{

		if (Bhead == NULL)
		{
			pcb[i].ID = i;
			Bhead = &pcb[i];
			Btail = &pcb[i];
		}
		else
		{
			pcb[i].ID = i;
			Btail->FWD = &pcb[i];
			pcb[i].BKWD = Btail;
			Btail = &pcb[i];
			Btail->FWD = NULL;
		}
	}


	void Create(int i)
	{
		PCB *p = Fhead, *q = NULL, *r = NULL, *s = NULL;
		while (1)
		{

			if (p->ID == i&&Ftail->ID == i)
			{
				Ftail = Ftail->BKWD;
				Ftail->FWD = NULL;
				Rtail->FWD = p;
				p->BKWD = Rtail;
				Rtail = p;
				break;
			}
			else if (p->ID == i&&Fhead->ID == i)
			{
				q = p;
				r = q->FWD;
				r->BKWD = q;
				q->FWD = NULL;
				r->BKWD = NULL;
				Fhead = r;
				Rtail->FWD = q;
				q->BKWD = Rtail;
				Rtail = q;
				break;
			}
			else if (p->ID == i&&Ftail->ID != i)
			{
				q = p->BKWD;
				s = p->FWD;
				q->FWD = s;
				s->BKWD = q;
				Rtail->FWD = p;
				p->BKWD = Rtail;
				p->FWD = NULL;
				Rtail = p;
				break;
			}
			p = p->FWD;
		}

	}

	void Delete(int i)
	{
		PCB *p = Rhead, *q = NULL, *r = NULL, *s = NULL;
		while (1)
		{

			if (p->ID == i&&Rtail->ID == i)
			{
				Rtail = Rtail->BKWD;
				Rtail->FWD = NULL;
				Ftail->FWD = p;
				p->BKWD = Ftail;
				Ftail = p;
				break;
			}
			else if (p->ID == i&&Rhead->ID == i)
			{
				q = p;
				r = q->FWD;
				r->BKWD = q;
				q->FWD = NULL;
				r->BKWD = NULL;
				Rhead = r;
				Ftail->FWD = q;
				q->BKWD = Ftail;
				Ftail = q;
				break;
			}
			else if (p->ID == i&&Rtail->ID != i)
			{
				q = p->BKWD;
				s = p->FWD;
				q->FWD = s;
				s->BKWD = q;
				Ftail->FWD = p;
				p->BKWD = Ftail;
				p->FWD = NULL;
				Ftail = p;
				break;
			}
			p = p->FWD;
		}
	}

	void Wait(int i)
	{
		PCB *p = Rhead, *q = NULL, *r = NULL, *s = NULL;
		while (1)
		{

			if (p->ID == i&&Rtail->ID == i)
			{
				Rtail = Rtail->BKWD;
				Rtail->FWD = NULL;
				Btail->FWD = p;
				p->BKWD = Btail;
				Btail = p;
				break;
			}
			else if (p->ID == i&&Rhead->ID == i)
			{
				q = p;
				r = q->FWD;
				r->BKWD = q;
				q->FWD = NULL;
				r->BKWD = NULL;
				Rhead = r;
				Btail->FWD = q;
				q->BKWD = Btail;
				Btail = q;
				break;
			}
			else if (p->ID == i&&Rtail->ID != i)
			{
				q = p->BKWD;
				s = p->FWD;
				q->FWD = s;
				s->BKWD = q;
				Btail->FWD = p;
				p->BKWD = Btail;
				p->FWD = NULL;
				Btail = p;
				break;
			}
			p = p->FWD;
		}
	}
	void display()
	{
		PCB *p, *q, *r;
		cout << "Ready List\n" << endl;
		for (p = Rhead; p != NULL; p = p->FWD)

			cout << p->ID << "  ";
		cout << "\n\n\nFree List\n" << endl;

		for (q = Fhead; q != NULL; q = q->FWD)
			cout << q->ID << "  ";

		cout << "\n\n\nBlock List\n" << endl;

		for (r = Bhead; r != NULL; r = r->FWD)
			cout << r->ID << "  ";

		cout << "" << endl;
	}
};


void main()
{
	OS obj;
	obj.Initilize_Ready_List(0);
	obj.Initilize_Ready_List(3);
	obj.Initilize_Ready_List(5);
	obj.Initilize_Ready_List(8);
	obj.Initilize_Ready_List(13);

	obj.Initilize_Free_List(1);
	obj.Initilize_Free_List(4);
	obj.Initilize_Free_List(6);
	obj.Initilize_Free_List(9);
	obj.Initilize_Free_List(15);

	obj.Initilize_Block_List(2);
	obj.Initilize_Block_List(7);
	obj.Initilize_Block_List(10);
	obj.Initilize_Block_List(11);
	obj.Initilize_Block_List(12);
	obj.Initilize_Block_List(14);
	obj.Initilize_Block_List(16);
	obj.Initilize_Block_List(17);
	obj.Initilize_Block_List(18);
	obj.Initilize_Block_List(19);

	obj.display();
	char choice;
	int a;
	do
	{
		cout << "Please Press:\n\t\tC: Create\n\t\tD: Delete\n\t\tW: Wait" << endl;
		cin >> choice;
		switch (choice)
		{
		case 'C':
		{
			cout << "Plaese Enter PCB Number From Free List" << endl;
			cin >> a;
			obj.Create(a);
			break;
		}
		case 'D':
		{
			cout << "Plaese Enter PCB Number From Ready List" << endl;
			cin >> a;
			obj.Delete(a);
			break;
		}
		case 'W':
		{
			cout << "Plaese Enter PCB Number From Ready List" << endl;
			cin >> a;
			obj.Wait(a);
			break;
		}
		}
		system("cls");
		cout << "Lists Are Updated \n" << endl;
		obj.display();
		cout << "Do You Want To Perform Again??(y/n) \n" << endl;
		cin >> choice;
	} while (choice == 'Y' || choice == 'y');
	system("pause");
}
