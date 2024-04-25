namespace PersonalProject
{
    class Item
    {
        public string name, content;
        public int ID, price, attackStat, defenseStat;

        public bool isBuy, isEquip;

        public Item(string _name, string _content, int _iD, int _price, int _attackStat, int _defenseStat, bool _isBuy, bool _isEquip)
        {
            
            this.name = _name;
            this.content = _content;
            this.ID = _iD;
            this.price = _price;
            this.attackStat = _attackStat;
            this.defenseStat = _defenseStat;
            this.isBuy = _isBuy;
            this.isEquip = _isEquip;
        }
    }

    internal class Program
    {
        static int Gold = 7000;

        static List<Item> itemList = new List<Item>();

        static void InitItem()
        {
            itemList.Add(new Item("수련자의 갑옷", "수련에 도움을 주는 갑옷입니다.", 1, 1000, 0, +5, false, false));
            itemList.Add(new Item("무쇠갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다.", 2, 2000, 0, +9, false, false));
            itemList.Add(new Item("스파르타 갑옷", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3, 3500, 0, +15, false, false));
            itemList.Add(new Item("낡은 검", "쉽게 볼 수 있는 낡은 검 입니다.", 4, 600, +2, 0, false, false));
            itemList.Add(new Item("청동 도끼", "어디선가 사용됐던거 같은 도끼입니다.", 5, 1500, +5, 0, false, false));
            itemList.Add(new Item("스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다.", 6, 3500, +7, 0, false, false));

        }

        static void Main()
        {
            ShowWelcomScreen();
            InitItem();
        }

        static void ShowWelcomScreen()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ShowStatus();
                    break;
                case "2":
                    OpenInven();
                    break;
                case "3":
                    VisitShop();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        static void ShowStatus()
        {
            Console.WriteLine();
            Console.WriteLine("Lv. 01");
            Console.WriteLine("타락파워전사 (전사)");
            Console.WriteLine("공격력 : 10");
            Console.WriteLine("방어력 : 5");
            Console.WriteLine("체 력 : 100");
            Console.WriteLine("Gold : " + $"{Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    Console.WriteLine("마을로 돌아갑니다.");
                    ShowWelcomScreen();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        static void OpenInven()     // 인벤토리를 열어주는 기능 구현 완료
        {            
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            // 여기에 보유 중인 아이템 목록을 출력하는 부분을 추가

            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    MgEquip();
                    break;
                case "0":
                    Console.WriteLine("마을로 돌아갑니다.");
                    ShowWelcomScreen();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;

            }
        }

        static void MgEquip()       // 장비 관리 기능을 구현
        {
            Console.WriteLine("장비 관리");
        }

        static void VisitShop()     // 상점을 방문하는 기능을 구현 완료
        {            
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{Gold} G"); // 보유 골드 표시 완료
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < itemList.Count; i++) 
            {
                Console.WriteLine(itemList[i].name);
                Console.WriteLine(itemList[i].content);
                Console.WriteLine(itemList[i].ID);
                Console.WriteLine(itemList[i].price);
                Console.WriteLine(itemList[i].attackStat);
                Console.WriteLine(itemList[i].defenseStat);
                Console.WriteLine(itemList[i].isBuy);
                Console.WriteLine(itemList[i].isEquip);
            }            
            Console.WriteLine("- 1 수련자 갑옷      | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.                    | 1000 G");
            Console.WriteLine("- 2 무쇠갑옷         | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.                | 2000 G");
            Console.WriteLine("- 3 스파르타 갑옷    | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | 3500 G");
            Console.WriteLine("- 4 낡은 검          | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.                   | 600 G");
            Console.WriteLine("- 5 청동 도끼        | 공격력 +5  | 어디선가 사용됐던거 같은 도끼입니다.              | 1500 G");
            Console.WriteLine("- 6 스파르타의 창    | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다.   | 3500 G");
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.Write("원하시는 행동을 선택하세요: ");

            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    BuyItem(); // 아이템 구매 기능 구현 완료
                    break;
                case "0":
                    Console.WriteLine("마을로 돌아갑니다.");
                    ShowWelcomScreen();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }

            static void BuyItem()
            {
                Console.WriteLine("구매할 아이템의 번호를 입력하세요");
                int itemNumber = Convert.ToInt32(Console.ReadLine());

                switch(itemNumber)
                {
                    case 1:
                        PurchaseItem("수련자의 갑옷", 1000);
                        break;
                    case 2:
                        PurchaseItem("무쇠 갑옷", 2000);
                        break;
                    case 3:
                        PurchaseItem("스파르타 갑옷", 3500);
                        break;
                    case 4:
                        PurchaseItem("낡은 검", 600);
                            break;
                    case 5:
                        PurchaseItem("청동 도끼", 1500);
                        break;
                    case 6:
                        PurchaseItem("스파르타의 창", 3500);
                        break;
                    default:
                        Console.WriteLine("잘못된 번호입니다.");
                        break;
                }
            }

            static void PurchaseItem(string itemName, int itemPrice)
            {
                if(Gold >= itemPrice)
                {
                    Console.WriteLine($"{itemName}를 구매하였습니다.");
                    Gold -= itemPrice;
                    Console.WriteLine($"남은 골드: {Gold} G");
                }
                else
                {
                    Console.WriteLine("골드가 부족합니다.");
                }

                Console.WriteLine();
                ShowWelcomScreen();
            }
        }
    }
}