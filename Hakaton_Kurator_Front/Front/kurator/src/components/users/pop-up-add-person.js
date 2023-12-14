"use client"
import "../../css/pop-up-add-person.css"

const PopUpAddPerson = () => {
    return (
        <fieldset className={"absolute border-2 border-sky-700 bg-white p-7 aaa"}>
            <h1 className={"text-4xl mb-10"}>Введите данные и роль нового пользователя </h1>
            <label className={"text-4xl"}>Почта</label>
            <br/>
            <input type="email" className={"border-2 border-slate-200 min-w-min email-pop-up rounded p-0.5 mb-6"}/>
            <p className={"text-4xl mb-4"}>Роль</p>
            <div>
                <input type="radio" id="admin" name="fav_language" value="admin"/>
                <label htmlFor="admin" className={"text-3xl mb-6 ml-1"}>Администратор</label><br/>
                <input type="radio" id="kur-st" name="fav_language" value="Student"/>
                <label htmlFor="kur-st" className={"text-3xl mb-6 ml-1"}>Куратор-студент</label><br/>
                <input type="radio" id="kur-teacher" name="fav_language" value="teacher"/>
                <label htmlFor="kur-teacher" className={"text-3xl mb-10 ml-1"}>Куратор-преподаватель</label><br/>
            </div>
            <input type="submit" value="Добавить" className={" bg-blue-700 text-4xl rounded text-white font-bold pl-7 pr-7 pb-1 pt-1 float-right"}/>
        </fieldset>
    )
}

export default PopUpAddPerson